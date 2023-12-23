﻿using EfficientWorkApp.Models;
using System.Collections.ObjectModel;
using System.Windows.Controls;

namespace Warmup
{
    public partial class WarmupPage : Page
    {
        public WarmupPage()
        {
            InitializeComponent();
            DataContext = this;
            addItem("15 раз", "Наклоны головы вперед-назад", "Встаньте прямо, расслабьте плечи.Теперь нужно медленно поднять голову и задержать её в этом положении на несколько секунд. Потом медленно опустить и коснуться подбородком груди. В этом положении тоже застыть на несколько секунд.");
            addItem("15 раз", "Наклоны головы влево-вправо", "Встаньте прямо, расслабьте плечи. Теперь нужно медленно наклонить голову в диагональ и задержать её в этом положении на несколько секунд. Потом медленно выпрямить и наклониться в другую сторону.");
            addItem("30 сек", "Наклоны головы влево-вправо с растяжением", "Стоя прямо, немного прогнитеасьв вперёд, чтобы подбородок был параллельно полу. Отведите руку в сторону и расположите лоадонь над противоположным ухом. Надавите на голову, стараясь отклонить её. Мышцы шеи должны сопротивлиться движению. Повторите упражнение по 3 раза по 5 секунд на обе стороны.");
            addItem("20 раз", "Разведение предплечий", "Встаньте прямо. Прижмите локти к корпусу. Поднимите предплечье параллельно полу, согнув локти. Отведите предплечья назад, задержитесь на несолько секунд. Далее приведите предплечья в исходное положение.");
            addItem("15 раз", "Подъёмы предплечий", "Встаньте прямо. Разведите руки в стороны. Согните предплечья на 90 градусов, чтобы ладони были параллельны полу. После этого поднимите руки максимально вверх, но так, чтобы плечи оставались параллельны полу. Потом вернитесь в исходное положение. Повторите упражнение.");
            addItem("30 раз", "Наклоны в сторону", "Встаньте прямо. Отведите правую или левую руку в сторону и потом положите ладонь на затылок. Напрягите мышцы пресса. Теперь сделайте наклон в сторону, руки держите параллельно телу. Почувствуйте небольшое растяжение и вернитесь в исходное положение. Повторите упражнение.");
            addItem("15 раз", "Наклоны головы вперед-назад", "Встаньте прямо, расслабьте плечи.Теперь нужно медленно поднять голову и задержать её в этом положении на несколько секунд. Потом медленно опустить и коснуться подбородком груди. В этом положении тоже застыть на несколько секунд.");
            addItem("15 раз", "Наклоны головы влево-вправо", "Встаньте прямо, расслабьте плечи. Теперь нужно медленно наклонить голову в диагональ и задержать её в этом положении на несколько секунд. Потом медленно выпрямить и наклониться в другую сторону.");
            addItem("30 сек", "Наклоны головы влево-вправо с растяжением", "Стоя прямо, немного прогнитеасьв вперёд, чтобы подбородок был параллельно полу. Отведите руку в сторону и расположите лоадонь над противоположным ухом. Надавите на голову, стараясь отклонить её. Мышцы шеи должны сопротивлиться движению. Повторите упражнение по 3 раза по 5 секунд на обе стороны.");
            addItem("20 раз", "Разведение предплечий", "Встаньте прямо. Прижмите локти к корпусу. Поднимите предплечье параллельно полу, согнув локти. Отведите предплечья назад, задержитесь на несолько секунд. Далее приведите предплечья в исходное положение.");
            addItem("15 раз", "Подъёмы предплечий", "Встаньте прямо. Разведите руки в стороны. Согните предплечья на 90 градусов, чтобы ладони были параллельны полу. После этого поднимите руки максимально вверх, но так, чтобы плечи оставались параллельны полу. Потом вернитесь в исходное положение. Повторите упражнение.");
            addItem("30 раз", "Наклоны в сторону", "Встаньте прямо. Отведите правую или левую руку в сторону и потом положите ладонь на затылок. Напрягите мышцы пресса. Теперь сделайте наклон в сторону, руки держите параллельно телу. Почувствуйте небольшое растяжение и вернитесь в исходное положение. Повторите упражнение.");
        }
        public ObservableCollection<WarmupItem> warmupItems { get; set; } = new ObservableCollection<WarmupItem>();

        private void addItem(string countText, string titleText, string multiLineText)
        {
            warmupItems.Add(new WarmupItem { countText = countText, titleText = titleText, multiLineText = multiLineText });
        }
    }
}
