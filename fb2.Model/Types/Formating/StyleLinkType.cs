namespace fb2.Model.Types.Formating
{
    using System.Xml.Serialization;

    using fb2.Model.Types.Base;
    using fb2.Model.Types.Enum;

    /// <summary>
    ///     The style link type.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [XmlType(Namespace = "http://www.gribuser.ru/xml/fictionbook/2.0")]
    public class StyleLinkType : BaseFormatingStyle
    {
        /// <summary>
        ///     The items element name field.
        /// </summary>
        private StyleLinkSupportedEnum[] itemsElementNameField;

        /// <summary>
        ///     The items field.
        /// </summary>
        private StyleLinkType[] itemsField;

        /// <summary>
        ///     The text field.
        /// </summary>
        private string[] textField;

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
        public StyleLinkSupportedEnum[] ItemsElementName
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
    }
}