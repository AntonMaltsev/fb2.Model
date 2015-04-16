namespace fb2.Model.Types.Data
{
    using System.Xml.Schema;
    using System.Xml.Serialization;

    using fb2.Model.Types.Base;

    /// <summary>
    ///     The image type.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [XmlType(Namespace = "http://www.gribuser.ru/xml/fictionbook/2.0")]
    public class ImageType : BaseTextData
    {
        /// <summary>
        ///     The alt field.
        /// </summary>
        private string altField;

        /// <summary>
        ///     The href field.
        /// </summary>
        private string hrefField;

        /// <summary>
        ///     The type field.
        /// </summary>
        private string typeField;

        /// <summary>
        ///     Initializes a new instance of the <see cref="ImageType" /> class.
        /// </summary>
        public ImageType()
        {
            this.typeField = "simple";
        }

        /// <summary>
        /// Gets or sets the content.
        /// </summary>
        /// <value>
        /// The content.
        /// </value>
        [XmlIgnore]
        public override string Text
        {
            get
            {
                return this.type;
            }
            set
            {
                this.type = value;
            }
        }

        /// <summary>
        /// The type.
        /// </summary>
        /// <value>
        /// The type.
        /// </value>
        [XmlAttribute(Form = XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/1999/xlink")]
        public string type
        {
            get
            {
                return this.typeField;
            }

            set
            {
                this.typeField = value;
            }
        }

        /// <summary>
        ///     The href.
        /// </summary>
        /// <remarks>
        /// </remarks>
        [XmlAttribute(Form = XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/1999/xlink")]
        public string href
        {
            get
            {
                return this.hrefField;
            }

            set
            {
                this.hrefField = value;
            }
        }

        /// <summary>
        ///     The alt.
        /// </summary>
        /// <remarks>
        /// </remarks>
        [XmlAttribute]
        public string alt
        {
            get
            {
                return this.altField;
            }

            set
            {
                this.altField = value;
            }
        }
    }
}