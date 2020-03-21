using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringBuilding
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "The quick brown fox\n\t";
            string b = " jumped over";
            string c = " the lazy dog\n";
            Console.WriteLine(a + b + c);
            

            StringBuilder builder = new StringBuilder();
            builder.AppendLine("Dark spruce forest frowned on either side of the frozen waterway.");
            builder.AppendLine("The trees had been stripped by a recent wind of their white covering of frost,\n and they seemed to lean toward each other, black and ominous, in the fading light.");
            builder.AppendLine("A vast silence reigned over the land.");
            builder.AppendLine("The land itself was a desolation, lifeless, without movement,\n so lone and cold that the spirit of it was not even that of sadness.");
            builder.AppendLine("There was a hint in it of laughter, but of a laughter more terrible than any sadness — a laughter that was mirthless as the smile of the Sphinx,\n a laughter cold as the frost and partaking of the grimness of infallibility.");
            builder.AppendLine("It was the masterful and incommunicable wisdom of eternity laughing at the futility of life and the effort of life.");
            builder.AppendLine("It was the Wild, the savage, frozen-hearted Northland Wild.");
            Console.WriteLine(builder);
            Console.ReadLine();
        }
    }
}
