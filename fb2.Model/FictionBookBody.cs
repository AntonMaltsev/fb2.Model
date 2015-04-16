namespace fb2.Model
{
    using System.Xml.Schema;
    using System.Xml.Serialization;

    using fb2.Model.Data;
    using fb2.Model.Formating;

    /// <summary>
    ///     The fiction book body.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [XmlType(AnonymousType = true, Namespace = "http://www.gribuser.ru/xml/fictionbook/2.0")]
    public class FictionBookBody
    {
        /// <summary>
        ///     The lang field.
        /// </summary>
        private string langField;

        /// <summary>
        ///     The name field.
        /// </summary>
        private string nameField;

        /// <summary>
        ///     The image.
        /// </summary>
        /// <value>
        ///     The image.
        /// </value>
        public ImageType image { get; set; }

        /// <summary>
        ///     The title.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public TitleType title { get; set; }

        /// <summary>
        ///     The epigraph.
        /// </summary>
        /// <remarks>
        /// </remarks>
        [XmlElement("epigraph")]
        public EpigraphType[] epigraph { get; set; }

        /// <summary>
        ///     The section.
        /// </summary>
        /// <remarks>
        /// </remarks>
        [XmlElement("section")]
        public SectionType[] section { get; set; }

        /// <summary>
        ///     The name.
        /// </summary>
        /// <remarks>
        /// </remarks>
        [XmlAttribute]
        public string name
        {
            get
            {
                return this.nameField;
            }

            set
            {
                this.nameField = value;
            }
        }

        /// <summary>
        ///     The lang.
        /// </summary>
        /// <remarks>
        /// </remarks>
        [XmlAttribute(Form = XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/XML/1998/namespace")]
        public string lang
        {
            get
            {
                return this.langField;
            }

            set
            {
                this.langField = value;
            }
        }
    }
}