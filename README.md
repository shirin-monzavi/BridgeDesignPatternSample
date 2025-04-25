# 🎨 Bridge Design Pattern with Abstract Factory in C#

This sample project demonstrates how to combine the **Bridge** and **Abstract Factory** design patterns in C# to create a flexible and extensible architecture for rendering shapes using different drawing systems (e.g., Windows or Mac).

---

## 🧠 Design Patterns Used

### 1. **Bridge Pattern**
- **Purpose:** Decouples an abstraction (`Shape`) from its implementation (`DrawingImplementor`), allowing them to vary independently.
- **Example:** A `Circle` delegates its drawing to a platform-specific `DrawingImplementor` (Windows or Mac).

### 2. **Abstract Factory Pattern**
- **Purpose:** Provides an interface to create families of related objects (`DrawingImplementor`) without specifying their concrete classes.
- **Example:** `WindowsDrawingFactory` and `MacDrawingFactory` create the appropriate drawing implementations.

---

### 🛠️ Technologies Used
 
C#
 
.NET Framework 7.0

### 🤝 Contributing
 
Feel free to fork the repository, submit pull requests, or open issues for improvements and discussions.

