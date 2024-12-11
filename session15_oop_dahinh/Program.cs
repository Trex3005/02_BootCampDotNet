using Newtonsoft.Json;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Animal dog = new Dog("Lulu", "Husky");
        // Gâu Gâu

        dog.Speak(); // lấy hàm Speak của class Dog
        dog.displayInfo(); // lấy hàm displayInfo của class Dog

        // Dùng class Animal để đại diện cho các class con
        List<Animal> animals = new List<Animal>();

        // tạo đối tượng Dog
        Dog dog1 = new Dog("hehe", "Bulldog");

        // add dog1 vào list animals
        animals.Add(dog1);

        // tạo đối tượng Cat
        Cat cat = new Cat("Meo", "White");
        // add đối tượng cat vào list animals
        animals.Add(cat);

        // in ra list animals
        foreach (var animal in animals)
        {
            animal.Speak();
            animal.displayInfo();
            Console.WriteLine("=======");
        }
        // Lưu list animals vào file json
        string json = JsonConvert.SerializeObject(animals, new JsonSerializerSettings
        {
            TypeNameHandling = TypeNameHandling.All,
            Formatting = Formatting.Indented
        });  
        File.WriteAllText("animal.json", json);
        Console.WriteLine("Lưu file thành công!");

        // Đọc file json
        string jsonFromFile = File.ReadAllText("animals.json");
        List<Animal> animals1 = JsonConvert.DeserializeObject<List<Animal>>(jsonFromFile);
        Console.WriteLine("Đọc file trước khi update");
        // Lỗi vì khi load file lên thì các object trong list animal
        // không phải là Dog hoặc Cat, mà là Animal

        // Solution
        // Để fix lỗi này ta cần lưu type của object vào file json
        foreach(var animal in animals1)
        {
            animal.Speak();
            animal.displayInfo();
            Console.WriteLine("========");
        }
}
}