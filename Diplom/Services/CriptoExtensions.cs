using Google.Protobuf.WellKnownTypes;
using System;
using System.ComponentModel;
using System.Reflection;
using Tinkoff.InvestApi.V1;

namespace Main.Extensions
{
    public static class CriptoExtensions
    {
        public static string GetHashString(this string password)
        {
            using (var sha = new System.Security.Cryptography.SHA256Managed())
            {
                byte[] textData = System.Text.Encoding.UTF8.GetBytes(password);
                byte[] hash = sha.ComputeHash(textData);
                return BitConverter.ToString(hash);
            }
        }
    }
}