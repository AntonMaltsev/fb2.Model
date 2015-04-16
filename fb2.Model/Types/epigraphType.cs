namespace fb2.Model.Types
{
    using System.Xml.Serialization;

    using fb2.Model.Types.Data;
    using fb2.Model.Types.Formating;

    /// <summary>
    ///     The epigraph type.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [XmlType(Namespace = "http://www.gribuser.ru/xml/fictionbook/2.0")]
    public class EpigraphType
    {
        /// <summary>
        ///     The id field.
        /// </summary>
        private string idField;

        /// <summary>
        ///     The items field.
        /// </summary>
        private object[] itemsField;

        /// <summary>
        ///     The textauthor field.
        /// </summary>
        private TextFieldType[] textauthorField;

        /// <summary>
        ///     The items.
        /// </summary>
        /// <remarks>
        /// </remarks>
        [XmlElement("cite", typeof(CiteType))]
        [XmlElement("empty-line", typeof(object))]
        [XmlElement("p", typeof(PType))]
        [XmlElement("poem", typeof(PoemType))]
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
    }
}