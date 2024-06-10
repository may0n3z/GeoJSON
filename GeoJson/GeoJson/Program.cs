using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GeoJson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"C:\Users\Student\Desktop\ИСП-8\GeoJson";

            var geoJsonData = GeoJSONLibrary.LoadGeoJSON(filePath);

            var geometryType = GeoJSONLibrary.GetGeometryType(geoJsonData);
            Console.WriteLine("Тип геометрии: " + geometryType);

            var coordinates = GeoJSONLibrary.GetCoordinates(geoJsonData);
            Console.WriteLine("Координаты: " +  coordinates);

            var area = GeoJSONLibrary.CalculateArea(geoJsonData);
            Console.WriteLine("Площадь: " + area);

            var nearestFeature = GeoJSONLibrary.CalculateDistance(geoJsonData, new double[] { 0, 0 });
            Console.WriteLine("Ближайший объект: " + nearestFeature);

            string outputfilePath = @"C:\Users\Student\Desktop\ИСП-8\GeoJson";
            GeoJSONLibrary.SaveGeoJSON(outputfilePath, geoJsonData);
            Console.WriteLine("GeoJson сохранен в: " + outputfilePath);
        }
    }
}
