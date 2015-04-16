namespace fb2.Model.Types.Formating
{
    using System.Xml.Schema;
    using System.Xml.Serialization;

    using fb2.Model.Types.Data;
    using fb2.Model.Types.Enum;

    /// <summary>
    ///     The named style type.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [XmlType(Namespace = "http://www.gribuser.ru/xml/fictionbook/2.0")]
    public class NamedStyleType
    {
        /// <summary>
        ///     The items element name field.
        /// </summary>
        private ItemsChoiceType3[] itemsElementNameField;

        /// <summary>
        ///     The items field.
        /// </summary>
        private object[] itemsField;

        /// <summary>
        ///     The lang field.
        /// </summary>
        private string langField;

        /// <summary>
        ///     The name field.
        /// </summary>
        private string nameField;

        /// <summary>
        ///     The text field.
        /// </summary>
        private string[] textField;

        /// <summary>
        ///     The items.
        /// </summary>
        /// <remarks>
        /// </remarks>
        [XmlElement("a", typeof(LinkType))]
        [XmlElement("emphasis", typeof(StyleType))]
        [XmlElement("image", typeof(ImageType))]
        [XmlElement("strong", typeof(StyleType))]
        [XmlElement("style", typeof(NamedStyleType))]
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
        [XmlElement("ItemsElementName")]
        [XmlIgnore]
        public ItemsChoiceType3[] ItemsElementName
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

        /// <summary>
        ///     The name.
        /// </summary>
        /// <remarks>
        /// </remarks>
        [XmlAttribute(DataType = "token")]
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
    }
}