🔁 Dependency Inversion Principle (DIP) — Example
This repository demonstrates the Dependency Inversion Principle (DIP), the fifth of the SOLID design principles in object-oriented programming.

📌 What is DIP?

Definition:

High-level modules should not depend on low-level modules. Both should depend on abstractions.
Abstractions should not depend on details. Details should depend on abstractions.

⚠ The Problem This Example Highlights

In the provided code (before applying DIP):

The NewOrderProcessor class directly creates and uses concrete implementations like EmailNotifier, SmsNotifier, and SqlOrderRepository.

This makes the business logic tightly coupled to the details of notification and data persistence.

👉 This breaks DIP because:

Any change in the notification logic (e.g., switching from email to push notifications) requires modifying the business logic.

The high-level class (NewOrderProcessor) is directly dependent on low-level modules.

✅ The Goal

Separate concerns and depend on abstractions:

INotifier → Interface for sending notifications

IOrderRepository → Interface for saving orders

NewOrderProcessor → Depends only on the interfaces

➡ Concrete implementations are injected through constructors — allowing flexibility, easier testing, and extension.

💡 Why DIP matters

✅ Decouples business logic from infrastructure
✅ Makes testing easier (use mock/stub implementations)
✅ Easier to extend (add new notifier types without touching core logic)
✅ More maintainable and robust system

🚀 How to use

1️⃣ Clone the repo
2️⃣ Review the tightly coupled NewOrderProcessor
3️⃣ See the refactored version using interfaces
4️⃣ Try swapping in different notifier or repo implementations

