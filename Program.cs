using System;

class Hello {
    public void hello() {
        Console.WriteLine("Hello World!");
    }
}

namespace HelloWorld {
    static class Program {
        private static void Main(string[] args) {
            var hello = new Hello();

            hello.hello();
        }
    }
}