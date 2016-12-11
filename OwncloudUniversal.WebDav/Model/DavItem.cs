﻿using System;
using OwncloudUniversal.Shared.Model;

namespace OwncloudUniversal.WebDav.Model
{
    public class DavItem : AbstractItem
    {
        public string Href { get; set; }
        public string Etag { get; set; }
        public string ContentType { get; set; }
        public DateTime LastModified { get; set; }
        public string DisplayName { get; set; }
        public override string EntityId
        {
            get
            {
                return Href;
            }

            set
            {
                Href = value;
            }
        }
        public override string ChangeKey
        {
            get
            {
                return Etag;
            }

            set
            {
                Etag = value;
            }
        }

        public override Type AdapterType => typeof(WebDavAdapter);
    }
}