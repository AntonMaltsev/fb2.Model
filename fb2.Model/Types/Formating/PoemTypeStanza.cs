namespace fb2.Model.Types.Formating
{
    using System.Xml.Schema;
    using System.Xml.Serialization;

    /// <summary>
    ///     The poem type stanza.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [XmlType(AnonymousType = true, Namespace = "http://www.gribuser.ru/xml/fictionbook/2.0")]
    public class PoemTypeStanza
    {
        /// <summary>
        ///     The lang field.
        /// </summary>
        private string langField;

        /// <summary>
        ///     The subtitle field.
        /// </summary>
        private PType subtitleField;

        /// <summary>
        ///     The title field.
        /// </summary>
        private TitleType titleField;

        /// <summary>
        ///     The v field.
        /// </summary>
        private PType[] vField;

        /// <summary>
        ///     The title.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public TitleType title
        {
            get
            {
                return this.titleField;
            }

            set
            {
                this.titleField = value;
            }
        }

        /// <summary>
        ///     The subtitle.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public PType subtitle
        {
            get
            {
                return this.subtitleField;
            }

            set
            {
                this.subtitleField = value;
            }
        }

        /// <summary>
        ///     The v.
        /// </summary>
        /// <remarks>
        /// </remarks>
        [XmlElement("v")]
        public PType[] v
        {
            get
            {
                return this.vField;
            }

            set
            {
                this.vField = value;
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