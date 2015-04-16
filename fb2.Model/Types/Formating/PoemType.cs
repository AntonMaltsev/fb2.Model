namespace fb2.Model.Types.Formating
{
    using System.Xml.Schema;
    using System.Xml.Serialization;

    using fb2.Model.Types.Base;
    using fb2.Model.Types.Data;

    /// <summary>
    ///     The poem type.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [XmlType(Namespace = "http://www.gribuser.ru/xml/fictionbook/2.0")]
    public class PoemType : BaseFormatingStyle
    {
        /// <summary>
        ///     The date field.
        /// </summary>
        private DateType dateField;

        /// <summary>
        ///     The epigraph field.
        /// </summary>
        private EpigraphType[] epigraphField;

        /// <summary>
        ///     The id field.
        /// </summary>
        private string idField;

        /// <summary>
        ///     The lang field.
        /// </summary>
        private string langField;

        /// <summary>
        ///     The stanza field.
        /// </summary>
        private PoemTypeStanza[] stanzaField;

        /// <summary>
        ///     The textauthor field.
        /// </summary>
        private TextFieldType[] textauthorField;

        /// <summary>
        ///     The title field.
        /// </summary>
        private TitleType titleField;

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
        ///     The epigraph.
        /// </summary>
        /// <remarks>
        /// </remarks>
        [XmlElement("epigraph")]
        public EpigraphType[] epigraph
        {
            get
            {
                return this.epigraphField;
            }

            set
            {
                this.epigraphField = value;
            }
        }

        /// <summary>
        ///     The stanza.
        /// </summary>
        /// <remarks>
        /// </remarks>
        [XmlElement("stanza")]
        public PoemTypeStanza[] stanza
        {
            get
            {
                return this.stanzaField;
            }

            set
            {
                this.stanzaField = value;
            }
        }

        /// <summary>
        ///     The textauthor.
        /// </summary>
        /// <remarks>
        /// </remarks>
        [XmlElement("text-author")]
        public TextFieldType[] textauthor
        {
            get
            {
                return this.textauthorField;
            }

            set
            {
                this.textauthorField = value;
            }
        }

        /// <summary>
        ///     The date.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public DateType date
        {
            get
            {
                return this.dateField;
            }

            set
            {
                this.dateField = value;
            }
        }

        /// <summary>
        ///     The id.
        /// </summary>
        /// <remarks>
        /// </remarks>
        [XmlAttribute(DataType = "ID")]
        public string id
        {
            get
            {
                return this.idField;
            }

            set
            {
                this.idField = value;
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