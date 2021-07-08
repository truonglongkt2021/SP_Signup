using Microsoft.SharePoint.Client;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SP_Signup.Common
{
    public static class CommonServices
    {
        public static FileCollection GetAttachments(ClientContext ctx, List list, ListItem item)
        {
            ctx.Load(list, l => l.RootFolder.ServerRelativeUrl);
            ctx.Load(ctx.Site, s => s.Url);
            ctx.ExecuteQuery();

            Microsoft.SharePoint.Client.Folder attFolder = ctx.Web.GetFolderByServerRelativeUrl(list.RootFolder.ServerRelativeUrl + "/Attachments/" + item.Id);
            FileCollection files = attFolder.Files;

            ctx.Load(files, fs => fs.Include(f => f.ServerRelativeUrl, f => f.Name, f => f.ServerRelativeUrl));
            ctx.ExecuteQuery();

            return files;

        }

        public static void Download(string serverFilePath, string destPath, ClientContext context, string filename)
        {
            using (FileInformation ffl = Microsoft.SharePoint.Client.File.OpenBinaryDirect(context, serverFilePath))
            {
                if (!System.IO.Directory.Exists("download\\" + destPath))
                {
                    Directory.CreateDirectory("download\\" + destPath);
                }
                    using (FileStream fileStream = System.IO.File.Create("download\\"+ destPath + "\\" + filename))
                    {
                        using (MemoryStream stream = new MemoryStream())
                        {
                            ffl.Stream.CopyTo(stream);
                            stream.WriteTo(fileStream);
                        }
                    }
            }
        }
    }
}
