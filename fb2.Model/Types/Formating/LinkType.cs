namespace fb2.Model.Types.Formating
{
    using System.Xml.Schema;
    using System.Xml.Serialization;

    using fb2.Model.Types.Enum;

    /// <summary>
    ///     The link type.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [XmlType(Namespace = "http://www.gribuser.ru/xml/fictionbook/2.0")]
    public class LinkType
    {
        /// <summary>
        ///     The href field.
        /// </summary>
        private string hrefField;

        /// <summary>
        ///     The items element name field.
        /// </summary>
        private ItemsChoiceType2[] itemsElementNameField;

        /// <summary>
        ///     The items field.
        /// </summary>
        private StyleLinkType[] itemsField;

        /// <summary>
        ///     The text field.
        /// </summary>
        private string[] textField;

        /// <summary>
        ///     The type 1 field.
        /// </summary>
        private string type1Field;

        /// <summary>
        ///     The type field.
        /// </summary>
        private string typeField;

        /// <summary>
        ///     Initializes a new instance of the <see cref="LinkType" /> class.
        /// </summary>
        public LinkType()
        {
            this.typeField = "simple";
        }

        /// <summary>
        ///     The items.
        /// </summary>
        /// <remarks>
        /// </remarks>
        [XmlElement("emphasis", typeof(StyleLinkType))]
        [XmlElement("strong", typeof(StyleLinkType))]
        [XmlElement("style", typeof(StyleLinkType))]
        [XmlChoiceIdentifier("ItemsElementName")]
        public StyleLinkType[] Items
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
        [XmlElement("ItemsElementName")]
        [XmlIgnore]
        public ItemsChoiceType2[] ItemsElementName
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
        ///     The text.
        /// </summary>
        /// <remarks>
        /// </remarks>
        [XmlText]
        public string[] Text
        {
            get
            {
                return this.textField;
            }

            set
            {
                this.textField = value;
            }
        }

        /// <summary>
        ///     The type.
        /// </summary>
        /// <remarks>
        /// </remarks>
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
        ///     The type 1.
        /// </summary>
        /// <remarks>
        /// </remarks>
        [XmlAttribute("type", DataType = "token")]
        public string type1
        {
            get
            {
                return this.type1Field;
            }

            set
            {
                this.type1Field = value;
            }
        }
    }
}