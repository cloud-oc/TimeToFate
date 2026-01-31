<div align="center">

[简体中文](README.md) | [English](README.en.md) | [日本語](README.ja.md)

</div>

---

# TimeToFate - A Real-time Fortune Telling App

A Unity-based app that predicts events based on time. Although the principle is metaphysical, the algorithm is quite scientific.

The prediction principle is based on Taoism's Xiaoliu Ren (小六壬), using the time-based divination method. Instead of the traditional finger calculation by the fortune teller, this app automatically calculates it with a single press, eliminating the need to manually determine the lunar month, day, and current hour.

**Time-based Divination Method**

Calculation formula: If today is the b-th day of the a-th lunar month, and it's the c-th hour of the day, then x=(a+b+c-2)%6

| x       | 1                  | 2                            | 3                       | 4                             | 5          | 6                       |
| ------- | ------------------ | ---------------------------- | ----------------------- | ----------------------------- | ---------- | ----------------------- |
| Fortune | Great Luck (Da An) | Lingering (Small Misfortune) | Medium Luck (Swift Joy) | Red Mouth (Medium Misfortune) | Small Luck | Void (Great Misfortune) |

## 🎬 Video Demo

https://github.com/user-attachments/assets/af1d133e-c536-426a-a805-7dbe2b277878

**Note**

During the research process, I discovered that the Xiaoliu Ren algorithm is not standardized and varies across different schools such as the Daoist transmission, Jiang's, and Shao's schools. This project uses what is said to be the most widely adopted Daoist transmission algorithm. As for its accuracy, that's for individuals to judge for themselves. While one should not blindly superstitious about Feng Shui, using it as a guide for personal conduct and decision-making is acceptable.
