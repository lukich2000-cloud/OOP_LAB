using System;
using System.Collections.Generic;
using Xunit;

namespace Lab2.Myproject.Tests
{       
    public class ItemTests
    {
        [Fact]
        public void Gun_Use_ShouldReturnCorrectMessage()
        {
            var gun = new Gun(1, "Пистолет", "Описание", 2, 30);
            var result = gun.use();
            Assert.Contains("Пистолет", result);
            Assert.Contains("30", result);
        }

        [Fact]
        public void Poison_Use_ShouldReturnCorrectMessage()
        {
            var poison = new Poison(1, "Зелье", "Описание", 1, 5, "Сила");
            var result = poison.use();
            Assert.Contains("Зелье", result);
            Assert.Contains("Сила", result);
            Assert.Contains("5", result);
        }

        [Fact]
        public void QuestItem_Use_ShouldReturnCorrectMessage()
        {
            var questItem = new QuestItem(0, "Артефакт", "Описание", 1, "Квест", true, false);
            var result = questItem.use();
            Assert.Contains("Артефакт", result);
        }

        [Fact]
        public void Shield_Use_ShouldReturnCorrectMessage()
        {
            var shield = new Shiled(2, "Щит", "Описание", 5, 15);
            var result = shield.use();
            Assert.Contains("Щит", result);
            Assert.Contains("15", result);
        }

    }

}