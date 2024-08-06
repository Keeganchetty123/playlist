using System;

public class Program
{
    public static void Main()
    {
        DoublyLinkedList playlist = new DoublyLinkedList();

        while (true)
        {
            Console.WriteLine("\nPlaylist Menu:");
            Console.WriteLine("1. Add Track");
            Console.WriteLine("2. Remove Track");
            Console.WriteLine("3. Next Track");
            Console.WriteLine("4. Previous Track");
            Console.WriteLine("5. Shuffle Tracks");
            Console.WriteLine("6. Display Playlist");
            Console.WriteLine("7. Current Track");
            Console.WriteLine("8. Exit");

            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Write("Enter the track name: ");
                    string addTrack = Console.ReadLine();
                    playlist.AddTrack(addTrack);
                    Console.WriteLine($"Track \"{addTrack}\" added.");
                    break;

                case "2":
                    Console.Write("Enter the track name to remove: ");
                    string removeTrack = Console.ReadLine();
                    if (playlist.RemoveTrack(removeTrack))
                    {
                        Console.WriteLine($"Track \"{removeTrack}\" removed.");
                    }
                    else
                    {
                        Console.WriteLine($"Track \"{removeTrack}\" not found in the playlist.");
                    }
                    break;

                case "3":
                    string nextTrack = playlist.NextTrack();
                    if (nextTrack != null)
                    {
                        Console.WriteLine($"Playing next track: {nextTrack}");
                    }
                    else
                    {
                        Console.WriteLine("No more tracks ahead.");
                    }
                    break;

                case "4":
                    string prevTrack = playlist.PrevTrack();
                    if (prevTrack != null)
                    {
                        Console.WriteLine($"Playing previous track: {prevTrack}");
                    }
                    else
                    {
                        Console.WriteLine("No more tracks behind.");
                    }
                    break;

                case "5":
                    playlist.ShuffleTracks();
                    Console.WriteLine("Playlist shuffled.");
                    break;

                case "6":
                    Console.WriteLine("Current Playlist:");
                    playlist.DisplayPlaylist();
                    break;

                case "7":
                    string currentTrack = playlist.CurrentTrack();
                    if (currentTrack != null)
                    {
                        Console.WriteLine($"Current track: {currentTrack}");
                    }
                    else
                    {
                        Console.WriteLine("No track is currently playing.");
                    }
                    break;

                case "8":
                    Console.WriteLine("Exiting...");
                    return;

                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
}
