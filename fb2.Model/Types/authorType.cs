namespace fb2.Model.Types
{
    using System.Diagnostics;
    using System.Xml.Serialization;

    using fb2.Model.Types.Data;
    using fb2.Model.Types.Enum;

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
        private ItemsChoiceType[] itemsElementNameField;

        /// <summary>
        ///     The items field.
        /// </summary>
        private object[] itemsField;

        /// <summary>
        ///     The items.
        /// </summary>
        /// <remarks>
        /// </remarks>
        [XmlElement("email", typeof(string))]
        [XmlElement("first-name", typeof(TextFieldType))]
        [XmlElement("home-page", typeof(string))]
        [XmlElement("last-name", typeof(TextFieldType))]
        [XmlElement("middle-name", typeof(TextFieldType))]
        [XmlElement("nickname", typeof(TextFieldType))]
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
        public ItemsChoiceType[] ItemsElementName
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