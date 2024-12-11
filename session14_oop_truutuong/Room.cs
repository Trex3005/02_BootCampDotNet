abstract class Room
{
    private string roomId;

    public string RoomId
    {
        get{return roomId;}
        set{roomId = value;}
    }
    private string roomName;
    public string RoomName
    {
        get{return roomName;}
        set{roomName = value;}
    }

    private double basePrice;

    public double BasePrice
    {
        get{return basePrice;}
        set{basePrice = value;}
    }

    public Room(string roomId, string roomName, double basePrice)
    {
        this.roomId = roomId;
        this.roomName = roomName;
        this.basePrice = basePrice;
    }

    public virtual void displayInfo()
    {
        Console.WriteLine($"Room Id: {roomId}");
        System.Console.WriteLine($"Room Name: {roomName}");
        System.Console.WriteLine($"Base Price: {basePrice}");
    }

    // Vì hàm này class con không  thể dùng được nên cần define abstract
    public abstract double calculatePrice();

}