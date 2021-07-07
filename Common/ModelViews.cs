using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SP_Signup.Common
{
    class ModelViews
    {
    }
    public class Metadata
    {
        public string id { get; set; }
        public string uri { get; set; }
        public string etag { get; set; }
        public string type { get; set; }
    }

    public class Deferred
    {
        public string uri { get; set; }
    }

    public class FirstUniqueAncestorSecurableObject
    {
        public Deferred __deferred { get; set; }
    }

    public class RoleAssignments
    {
        public Deferred __deferred { get; set; }
    }

    public class AttachmentFiles
    {
        public Deferred __deferred { get; set; }
    }

    public class ContentType
    {
        public Deferred __deferred { get; set; }
    }

    public class GetDlpPolicyTip
    {
        public Deferred __deferred { get; set; }
    }

    public class FieldValuesAsHtml
    {
        public Deferred __deferred { get; set; }
    }

    public class FieldValuesAsText
    {
        public Deferred __deferred { get; set; }
    }

    public class FieldValuesForEdit
    {
        public Deferred __deferred { get; set; }
    }

    public class File
    {
        public Deferred __deferred { get; set; }
    }

    public class Folder
    {
        public Deferred __deferred { get; set; }
    }

    public class LikedByInformation
    {
        public Deferred __deferred { get; set; }
    }

    public class ParentList
    {
        public Deferred __deferred { get; set; }
    }

    public class Properties
    {
        public Deferred __deferred { get; set; }
    }

    public class Versions
    {
        public Deferred __deferred { get; set; }
    }
    public class Attachment
    {
        public string FileName { get; set; }
        public string Uri { get; set; }
    }
    public class Result
    {
        public Result()
        {
            listAttachment = new List<Attachment>();
        }
        //public Metadata __metadata { get; set; }
        //public FirstUniqueAncestorSecurableObject FirstUniqueAncestorSecurableObject { get; set; }
        //public RoleAssignments RoleAssignments { get; set; }
        //public AttachmentFiles AttachmentFiles { get; set; }
        //public ContentType ContentType { get; set; }
        //public GetDlpPolicyTip GetDlpPolicyTip { get; set; }
        //public FieldValuesAsHtml FieldValuesAsHtml { get; set; }
        //public FieldValuesAsText FieldValuesAsText { get; set; }
        //public FieldValuesForEdit FieldValuesForEdit { get; set; }
        //public File File { get; set; }
        //public Folder Folder { get; set; }
        //public LikedByInformation LikedByInformation { get; set; }
        //public ParentList ParentList { get; set; }
        //public Properties Properties { get; set; }
        //public Versions Versions { get; set; }
        public int ID { get; set; }
        public List<Attachment> listAttachment { get; set; }
        //public string FileSystemObjectType { get; set; }
        //public string Id { get; set; }

        //public string ContentTypeId { get; set; }
        [DisplayName("受入番号")]
        public string Title { get; set; }
        //public object ComplianceAssetId { get; set; }
        [DisplayName("車系")]
        public string OData__x8eca__x7cfb_ { get; set; }
        [DisplayName("会社名")]
        public string OData__x4f1a__x793e__x540d_ { get; set; }
        [DisplayName("品番")]
        public string OData__x54c1__x756a_ { get; set; }
        [DisplayName("品........名")]
        public string OData_x54c1__x002e__x002e__x002e__x00 { get; set; }

        [DisplayName("新設")]
        public string OData__x65b0__x8a2d_ { get; set; }

        [DisplayName("納期")]
        public string OData__x7d0d__x671f_ { get; set; }

        [DisplayName("工数")]
        public string OData__x5de5__x6570_ { get; set; }

        [DisplayName("進行者")]
        public string OData__x9032__x884c__x8005_ { get; set; }
        public bool Attachments { get; set; }

        [DisplayName("型名称")]
        public string OData__x578b__x540d__x79f0_ { get; set; }
        public DateTime Modified { get; set; }
        public DateTime Created { get; set; }
        public object ServerRedirectedEmbedUri { get; set; }
        public string ServerRedirectedEmbedUrl { get; set; }
        public string AuthorId { get; set; }
        public string EditorId { get; set; }
        public string OData__UIVersionString { get; set; }
        public string GUID { get; set; }
    }

    public class D
    {
        public List<Result> results { get; set; }
        public string __next { get; set; }
    }

    public class Root
    {
        public D d { get; set; }
    }

}
