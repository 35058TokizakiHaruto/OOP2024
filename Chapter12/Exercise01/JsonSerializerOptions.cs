using System.Text.Json;

namespace Exercise01 {
    internal class JsonSerializerOptions {
        internal JsonNamingPolicy PropertyNamingPolicy;

        public object Encoder { get; set; }
        public bool WriteIndented { get; set; }
    }
}