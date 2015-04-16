namespace fb2.Model.Formating
{
    using System.Xml.Schema;
    using System.Xml.Serialization;

    using fb2.Model.Base;
    using fb2.Model.Data;

    /// <summary>
    ///     The cite type.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [XmlType(Namespace = "http://www.gribuser.ru/xml/fictionbook/2.0")]
    public class CiteType : BaseFormatingStyle
    {
        /// <summary>
        ///     The id field.
        /// </summary>
        private string idField;

        /// <summary>
        ///     The items field.
        /// </summary>
        private BaseFormatingStyle[] itemsField;

        /// <summary>
        ///     The lang field.
        /// </summary>
        private string langField;

        /// <summary>
        ///     The textauthor field.
        /// </summary>
        private TextFieldType[] textauthorField;

        /// <summary>
        ///     The items.
        /// </summary>
        /// <remarks>
        /// </remarks>
        [XmlElement("empty-line", typeof(BaseFormatingStyle))]
        [XmlElement("p", typeof(PType))]
        [XmlElement("poem", typeof(PoemType))]
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