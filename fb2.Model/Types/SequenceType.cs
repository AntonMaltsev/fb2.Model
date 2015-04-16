namespace fb2.Model.Types
{
    using System.Xml.Schema;
    using System.Xml.Serialization;

    /// <summary>
    ///     The sequence type.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [XmlType(Namespace = "http://www.gribuser.ru/xml/fictionbook/2.0")]
    public class SequenceType
    {
        /// <summary>
        ///     The lang field.
        /// </summary>
        private string langField;

        /// <summary>
        ///     The name field.
        /// </summary>
        private string nameField;

        /// <summary>
        ///     The number field.
        /// </summary>
        private string numberField;

        /// <summary>
        ///     The sequence field.
        /// </summary>
        private SequenceType[] sequenceField;

        /// <summary>
        ///     The sequence.
        /// </summary>
        /// <remarks>
        /// </remarks>
        [XmlElement("sequence")]
        public SequenceType[] sequence
        {
            get
            {
                return this.sequenceField;
            }

            set
            {
                this.sequenceField = value;
            }
        }

        /// <summary>
        ///     The name.
        /// </summary>
        /// <remarks>
        /// </remarks>
        [XmlAttribute]
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

        /// <summary>
        ///     The number.
        /// </summary>
        /// <remarks>
        /// </remarks>
        [XmlAttribute(DataType = "integer")]
        public string number
        {
            get
            {
                return this.numberField;
            }

            set
            {
                this.numberField = value;
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