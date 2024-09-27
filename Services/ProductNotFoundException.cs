using System;

namespace SKBKonturInternshipProject.Services
{
    public class ProductNotFoundException : Exception
    {
        public ProductNotFoundException(string message) : base(message) { }
    }
}