namespace fb2.Model.Formating
{
    using System.Xml.Schema;
    using System.Xml.Serialization;

    using fb2.Model.Base;

    /// <summary>
    ///     The annotation type.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [XmlType(Namespace = "http://www.gribuser.ru/xml/fictionbook/2.0")]
    public class AnnotationType
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
        ///     The items.
        /// </summary>
        /// <remarks>
        /// </remarks>
        [XmlElement("cite", typeof(CiteType))]
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