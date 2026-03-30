// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");

DataGeneric<string> dataNIM = new DataGeneric<string>("103082400051"); // Isi NIM kamu 
dataNIM.PrintData();

public class DataGeneric<T> {
    private T data;
    public DataGeneric(T data) { this.data = data; }
    public void PrintData() {
        Console.WriteLine($"Data yang tersimpan adalah: {this.data}");
    }
}