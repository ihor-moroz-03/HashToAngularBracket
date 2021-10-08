using System;

namespace HashToAngularBracket
{
    class Program
    {
        static void Main()
        {
            string[] example = @"##Aut dolores #incidunt consequuntur #qui doloribus eius sit.
# #Quidem omnis hic #sit et porro qui.
Recusandae est veniam sed asperiores repellendus. Iure repellendus autem sunt.
Unde unde omnis nulla laborum. Et voluptates omnis sed dolorum in #eius cupiditate.
#Cupiditate aut qui dolor.
Neque repellat accusantium# voluptatem quaerat et velit. Suscipit# cum odit eum veniam repellat et suscipit nemo.
Quas delectus aliquam fuga dolor iure voluptatem. Dolorem a modi consectetur quidem dicta dolorem.
####Qui ###animi ratione fugit# ##perferendis soluta quia dolor est. ##Modi est### optio quod.
Eaque amet dolores facilis impedit. Omnis nobis ad voluptatem.
Adipisci# sunt nemo beatae illo sed et voluptas beatae.
#Iste asperiores eum totam#. Cupiditate sunt ut ea dicta nemo ab accusamus facere.".Split('\n');

            Console.Write(string.Join<string>('\n', Formatter.Format(example)));
            Console.Read();
        }
    }
}
