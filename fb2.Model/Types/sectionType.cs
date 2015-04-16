namespace fb2.Model.Types
{
    using System.Xml.Schema;
    using System.Xml.Serialization;

    using fb2.Model.Types.Data;
    using fb2.Model.Types.Enum;
    using fb2.Model.Types.Formating;

    /// <summary>
    ///     The section type.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [XmlType(Namespace = "http://www.gribuser.ru/xml/fictionbook/2.0")]
    public class SectionType
    {
        /// <summary>
        ///     The annotation field.
        /// </summary>
        private AnnotationType annotationField;

        /// <summary>
        ///     The epigraph field.
        /// </summary>
        private EpigraphType[] epigraphField;

        /// <summary>
        ///     The id field.
        /// </summary>
        private string idField;

        /// <summary>
        ///     The image field.
        /// </summary>
        private ImageType imageField;

        /// <summary>
        ///     The items element name field.
        /// </summary>
        private ItemsChoiceType5[] itemsElementNameField;

        /// <summary>
        ///     The items field.
        /// </summary>
        private object[] itemsField;

        /// <summary>
        ///     The lang field.
        /// </summary>
        private string langField;

        /// <summary>
        ///     The title field.
        /// </summary>
        private TitleType titleField;

        /// <summary>
        ///     The title.
        /// </summary>
        /// <remarks>
        /// </remarks>
        [XmlElement(Order = 0)]
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
        [XmlElement("epigraph", Order = 1)]
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
        ///     The image.
        /// </summary>
        /// <remarks>
        /// </remarks>
        [XmlElement(Order = 2)]
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
        ///     The annotation.
        /// </summary>
        /// <remarks>
        /// </remarks>
        [XmlElement(Order = 3)]
        public AnnotationType annotation
        {
            get
            {
                return this.annotationField;
            }

            set
            {
                this.annotationField = value;
            }
        }

        /// <summary>
        ///     The items.
        /// </summary>
        /// <remarks>
        /// </remarks>
        [XmlElement("cite", typeof(CiteType), Order = 4)]
        [XmlElement("empty-line", typeof(object), Order = 4)]
        [XmlElement("image", typeof(ImageType), Order = 4)]
        [XmlElement("p", typeof(PType), Order = 4)]
        [XmlElement("poem", typeof(PoemType), Order = 4)]
        [XmlElement("section", typeof(SectionType), Order = 4)]
        [XmlElement("subtitle", typeof(PType), Order = 4)]
        [XmlElement("table", typeof(TableType), Order = 4)]
        [XmlChoiceIdentifier("ItemsElementName")]
        public object[] Items
        {
            get
            {
                return this.itemsField;
            }

            set
            {
                this.itemsField = value;
            }
        }

        /// <summary>
        ///     The items element name.
        /// </summary>
        /// <remarks>
        /// </remarks>
        [XmlElement("ItemsElementName", Order = 5)]
        [XmlIgnore]
        public ItemsChoiceType5[] ItemsElementName
        {
            get
            {
                return this.itemsElementNameField;
            }

            set
            {
                this.itemsElementNameField = value;
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