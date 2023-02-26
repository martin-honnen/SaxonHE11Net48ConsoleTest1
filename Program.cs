using System;
using net.liberty_development.SaxonHE11s9apiExtensions;
using net.sf.saxon.s9api;

namespace SaxonHE11Net48ConsoleTest1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(".NET {0}", Environment.Version);

            var processor = new Processor(false);

            Console.WriteLine("Saxon {0} {1}", processor.getSaxonEdition(), processor.getSaxonProductVersion());

            var xslt30Transformer = processor.newXsltCompiler().Compile(new Uri("https://raw.githubusercontent.com/martin-honnen/martin-honnen.github.io/master/xslt/processorTestHTML5Xslt3InitialTempl.xsl")).load30();

            xslt30Transformer.callTemplate(null, processor.NewSerializer(Console.Out));
        }
    }
}


