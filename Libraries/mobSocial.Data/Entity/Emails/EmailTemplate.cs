﻿using System.Web.Mvc;
using mobSocial.Core.Data;

namespace mobSocial.Data.Entity.Emails
{
    public class EmailTemplate : BaseEntity
    {
        public string TemplateName { get; set; }

        public string TemplateSystemName { get; set; }

        [AllowHtml]
        public string Template { get; set; }     

        public bool IsMaster { get; set; }

        public int? ParentEmailTemplateId { get; set; }

        public virtual EmailTemplate ParentEmailTemplate { get; set; }
    }

    public class EmailTemplateMap : BaseEntityConfiguration<EmailTemplate>
    {
        public EmailTemplateMap()
        {
            HasOptional(x => x.ParentEmailTemplate);
        }
    }
}