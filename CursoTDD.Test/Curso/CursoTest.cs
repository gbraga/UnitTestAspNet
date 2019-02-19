using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace CursoTDD.Test.Curso
{
    public class CursoTest 
    {
        [Fact]
        public void DeveCriarCurso()
        {
            var a = 1;
            var b = 1;

            Assert.Equal(a, b);
        }


        [Fact]
        public void DeveTerNome()
        {
            Assert.Equal(1, 2);
        }
    }
}
