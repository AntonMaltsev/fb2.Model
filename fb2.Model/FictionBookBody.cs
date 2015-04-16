namespace fb2.Model
{
    using System.Xml.Schema;
    using System.Xml.Serialization;

    using fb2.Model.Types;
    using fb2.Model.Types.Data;

    /// <summary>
    ///     The fiction book body.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [XmlType(AnonymousType = true, Namespace = "http://www.gribuser.ru/xml/fictionbook/2.0")]
    public class FictionBookBody
    {
        /// <summary>
        ///     The epigraph field.
        /// </summary>
        private EpigraphType[] epigraphField;

        /// <summary>
        ///     The image field.
        /// </summary>
        private ImageType imageField;

        /// <summary>
        ///     The lang field.
        /// </summary>
        private string langField;

        /// <summary>
        ///     The name field.
        /// </summary>
        private string nameField;

        /// <summary>
        ///     The section field.
        /// </summary>
        private SectionType[] sectionField;

        /// <summary>
        ///     The title field.
        /// </summary>
        private TitleType titleField;

        /// <summary>
        ///     The image.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public ImageType image
        {
            get
            {
                return this.imageField;
            }

            set
            {
                this.imageField = value;
            }
        }

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
        ///     The section.
        /// </summary>
        /// <remarks>
        /// </remarks>
        [XmlElement("section")]
        public SectionType[] section
        {
            get
            {
                return this.sectionField;
            }

            set
            {
                this.sectionField = value;
            }
        }

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