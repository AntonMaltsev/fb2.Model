namespace fb2.Model.Data
{
    using System.Xml.Schema;
    using System.Xml.Serialization;

    using fb2.Model.Base;

    /// <summary>
    ///     The image type.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [XmlType(Namespace = "http://www.gribuser.ru/xml/fictionbook/2.0")]
    public class ImageType : BaseTextData
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="ImageType" /> class.
        /// </summary>
        public ImageType()
        {
            this.type = "simple";
        }

        /// <summary>
        ///     Gets or sets the content.
        /// </summary>
        /// <value>
        ///     The content.
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
        ///     The type.
        /// </summary>
        /// <value>
        ///     The type.
        /// </value>
        [XmlAttribute(Form = XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/1999/xlink")]
        public string type { get; set; }

        /// <summary>
        ///     The href.
        /// </summary>
        /// <remarks>
        /// </remarks>
        [XmlAttribute(Form = XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/1999/xlink")]
        public string href { get; set; }

        /// <summary>
        ///     The alt.
        /// </summary>
        /// <remarks>
        /// </remarks>
        [XmlAttribute]
        public string alt { get; set; }
    }
}