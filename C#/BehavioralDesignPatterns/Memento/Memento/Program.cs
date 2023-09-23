using Memento;

Book book = new Book();
book.ISBN = "0450488357";
book.Title = "The Tommyknockers";
book.Author = "Stephen King";
book.ShowBook();
System.Threading.Thread.Sleep(2000);

// Set undo point
Caretaker history = new Caretaker();
history.Memento = book.CreateUndo();

// Modify book
book.ISBN = "0330376144";
book.Title = "The Rats";
book.Author = "James Herbert";
book.ShowBook();

// Undo
book.RestoreFromUndo(history.Memento);
book.ShowBook();