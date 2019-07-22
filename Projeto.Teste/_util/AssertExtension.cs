using System;
using Xunit;

namespace Projeto.Teste._util
{
   public static class AssertExtension
    { 
        public static void ComMensagem(this ArgumentException exception, string mensagem)
        {
            if (exception.Message == mensagem)
                Assert.True(true, $"Esperava a mensagem: '{ mensagem}'");

            else
                Assert.False(true);
        }
    }
}
