using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Google.Cloud.Vision.V1;

namespace CloudVison
{
    class ImageContentAnalysis
    {
        static void Main()
        {
            string[] images =
                {
                    "C:/repos/knowrage-google-cloud-vision/CloudVison/CloudVison/img/cat-3523992__480.jpg",
                    "C:/repos/knowrage-google-cloud-vision/CloudVison/CloudVison/img/person-3519503__480.jpg",
                    "C:/repos/knowrage-google-cloud-vision/CloudVison/CloudVison/img/roses-3481982__480.jpg",
                };
            if (images.Length == 0) return;
            // クライアントを作成する
            var client = ImageAnnotatorClient.Create();
            foreach (var file in images)
            {
                // Image.FromFile ファイルを指定する
                var image = Image.FromFile(file);
                // クライアントを利用して Cloud Vision APIにリクエストを送信する
                var response = client.DetectLabels(image);
                Console.WriteLine($"About file: {file}");
                foreach (var label in response)
                {
                    Console.WriteLine(label);
                }
                Console.WriteLine();
            }
            // ユーザーによって押された次の文字キー、もしくはファンクションキーを取得する
            // 押されたキーはコンソールウィンドウに表示される
            Console.ReadKey();
        }
    }
}
