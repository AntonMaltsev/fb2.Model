namespace fb2.Model.Formating
{
    using System.Diagnostics;
    using System.Xml.Serialization;

    using fb2.Model.Base;
    using fb2.Model.Data;
    using fb2.Model.Enum;

    /// <summary>
    ///     The author type.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [DebuggerStepThrough]
    [XmlType(Namespace = "http://www.gribuser.ru/xml/fictionbook/2.0")]
    public class AuthorType
    {
        /// <summary>
        ///     The items element name field.
        /// </summary>
        private AuthorSupportedEnum[] itemsElementNameField;

        /// <summary>
        ///     The items field.
        /// </summary>
        private BaseTextData[] itemsField;

        /// <summary>
        ///     The items.
        /// </summary>
        /// <remarks>
        /// </remarks>
        [XmlElement("email", typeof(BaseTextData))]
        [XmlElement("first-name", typeof(TextFieldType))]
        [XmlElement("home-page", typeof(BaseTextData))]
        [XmlElement("last-name", typeof(TextFieldType))]
        [XmlElement("middle-name", typeof(TextFieldType))]
        [XmlElement("nickname", typeof(TextFieldType))]
        [XmlChoiceIdentifier("ItemsElementName")]
        public BaseTextData[] Items
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
        public AuthorSupportedEnum[] ItemsElementName
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
    }
}