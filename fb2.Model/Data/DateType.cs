namespace fb2.Model.Data
{
    using System;
    using System.Xml.Schema;
    using System.Xml.Serialization;

    using fb2.Model.Base;

    /// <summary>
    ///     The date type.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [XmlType(Namespace = "http://www.gribuser.ru/xml/fictionbook/2.0")]
    public class DateType : BaseTextData
    {
        /// <summary>
        ///     The value.
        /// </summary>
        /// <remarks>
        /// </remarks>
        [XmlAttribute(DataType = "date")]
        public DateTime value { get; set; }

        /// <summary>
        ///     The value specified.
        /// </summary>
        /// <remarks>
        /// </remarks>
        [XmlIgnore]
        public bool valueSpecified { get; set; }

        /// <summary>
        ///     The lang.
        /// </summary>
        /// <value>
        ///     The language.
        /// </value>
        [XmlAttribute(Form = XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/XML/1998/namespace")]
        public string lang { get; set; }

        /// <summary>
        ///     The value.
        /// </summary>
        /// <value>
        ///     The content.
        /// </value>
        [XmlText]
        public override string Text { get; set; }
    }
}