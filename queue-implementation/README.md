# Circular Queue Implementation in VB.NET

A beginner-friendly VB.NET console application that demonstrates how a circular queue works using an array-based structure.

The program follows the FIFO principle, where the first item added is the first item removed. It includes enqueue, dequeue, overflow, underflow, and display functionality.

---

## Features

- Circular queue implementation
- Enqueue operation
- Dequeue operation
- Queue overflow check
- Queue underflow check
- Display queue contents
- Fixed-size array-based storage

---

## Tech Stack

- VB.NET
- .NET 8
- Console Application

---

## How It Works

The queue uses two pointers:

- `front` → tracks the first item
- `rear` → tracks the last item

When the rear reaches the end of the array, it wraps around using the modulo operator:

```vb
rear = (rear + 1) Mod MAX_SIZE
