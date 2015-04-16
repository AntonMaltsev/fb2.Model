namespace fb2.Model.Formating
{
    using System.Xml.Schema;
    using System.Xml.Serialization;

    using fb2.Model.Base;

    /// <summary>
    ///     The title type.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [XmlType(Namespace = "http://www.gribuser.ru/xml/fictionbook/2.0")]
    public class TitleType : BaseFormatingStyle
    {
        /// <summary>
        ///     The items field.
        /// </summary>
        private BaseFormatingStyle[] itemsField;

        /// <summary>
        ///     The lang field.
        /// </summary>
        private string langField;

        /// <summary>
        ///     The items.
        /// </summary>
        /// <remarks>
        /// </remarks>
        [XmlElement("empty-line", typeof(BaseFormatingStyle))]
        [XmlElement("p", typeof(PType))]
        public BaseFormatingStyle[] Items
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