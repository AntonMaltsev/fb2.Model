namespace fb2.Model.Description
{
    using System.Xml.Serialization;

    /// <summary>
    ///     The fiction book description.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [XmlType(AnonymousType = true, Namespace = "http://www.gribuser.ru/xml/fictionbook/2.0")]
    public class FictionBookDescription
    {
        /// <summary>
        ///     The custominfo field.
        /// </summary>
        private FictionBookDescriptionCustominfo[] custominfoField;

        /// <summary>
        ///     The documentinfo field.
        /// </summary>
        private FictionBookDescriptionDocumentinfo documentinfoField;

        /// <summary>
        ///     The publishinfo field.
        /// </summary>
        private FictionBookDescriptionPublishinfo publishinfoField;

        /// <summary>
        ///     The titleinfo field.
        /// </summary>
        private FictionBookDescriptionTitleinfo titleinfoField;

        /// <summary>
        ///     The titleinfo.
        /// </summary>
        /// <remarks>
        /// </remarks>
        [XmlElement("title-info")]
        public FictionBookDescriptionTitleinfo titleinfo
        {
            get
            {
                return this.titleinfoField;
            }

            set
            {
                this.titleinfoField = value;
            }
        }

        /// <summary>
        ///     The documentinfo.
        /// </summary>
        /// <remarks>
        /// </remarks>
        [XmlElement("document-info")]
        public FictionBookDescriptionDocumentinfo documentinfo
        {
            get
            {
                return this.documentinfoField;
            }

            set
            {
                this.documentinfoField = value;
            }
        }

        /// <summary>
        ///     The publishinfo.
        /// </summary>
        /// <remarks>
        /// </remarks>
        [XmlElement("publish-info")]
        public FictionBookDescriptionPublishinfo publishinfo
        {
            get
            {
                return this.publishinfoField;
            }

            set
            {
                this.publishinfoField = value;
            }
        }

        /// <summary>
        ///     The custominfo.
        /// </summary>
        /// <remarks>
        /// </remarks>
        [XmlElement("custom-info")]
        public FictionBookDescriptionCustominfo[] custominfo
        {
            get
            {
                return this.custominfoField;
            }

            set
            {
                this.custominfoField = value;
            }
        }
    }
}