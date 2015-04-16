namespace fb2.Model.Types.Data
{
    using System;
    using System.Xml.Schema;
    using System.Xml.Serialization;

    using fb2.Model.Types.Base;

    /// <summary>
    ///     The date type.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [XmlType(Namespace = "http://www.gribuser.ru/xml/fictionbook/2.0")]
    public class DateType : BaseTextData
    {
        /// <summary>
        ///     The lang field.
        /// </summary>
        private string langField;

        /// <summary>
        ///     The value field.
        /// </summary>
        private DateTime valueField;

        /// <summary>
        ///     The value field 1.
        /// </summary>
        private string valueField1;

        /// <summary>
        ///     The value field specified.
        /// </summary>
        private bool valueFieldSpecified;

        /// <summary>
        ///     The value.
        /// </summary>
        /// <remarks>
        /// </remarks>
        [XmlAttribute(DataType = "date")]
        public DateTime value
        {
            get
            {
                return this.valueField;
            }

            set
            {
                this.valueField = value;
            }
        }

        /// <summary>
        ///     The value specified.
        /// </summary>
        /// <remarks>
        /// </remarks>
        [XmlIgnore]
        public bool valueSpecified
        {
            get
            {
                return this.valueFieldSpecified;
            }

            set
            {
                this.valueFieldSpecified = value;
            }
        }

        /// <summary>
        /// The lang.
        /// </summary>
        /// <value>
        /// The language.
        /// </value>
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
        /// The value.
        /// </summary>
        /// <value>
        /// The content.
        /// </value>
        [XmlText]
        public override string Text
        {
            get
            {
                return this.valueField1;
            }

            set
            {
                this.valueField1 = value;
            }
        }
    }
}