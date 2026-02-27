using System;

namespace _1Erronka_API.DTOak
{
    /// <summary>
    /// Langilearen datuak transferitzeko objektua.
    /// </summary>
    public class LangileaDto
    {
        /// <summary>
        /// Langilearen identifikadorea.
        /// </summary>
        public virtual int Id { get; set; }

        /// <summary>
        /// Langilearen izena.
        /// </summary>
        public virtual string Izena { get; set; }

        /// <summary>
        /// Langilearen erabiltzaile izena sisteman.
        /// </summary>
        public virtual string Erabiltzaile_izena { get; set; }

        /// <summary>
        /// Langilearen kodea.
        /// </summary>
        public int Langile_kodea { get; set; }

        /// <summary>
        /// Langilearen pasahitza (hash).
        /// </summary>
        public virtual string Pasahitza { get; set; }

        /// <summary>
        /// Langilea gerentea den edo ez.
        /// </summary>
        public virtual Boolean Gerentea { get; set; }

        /// <summary>
        /// TPV-ra sartzeko baimena duen edo ez.
        /// </summary>
        public virtual Boolean TpvSarrera { get; set; }
    }
}
