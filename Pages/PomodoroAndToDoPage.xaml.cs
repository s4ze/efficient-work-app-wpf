using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data.Linq;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Threading;



namespace pomodoro
{
    public partial class PomodoroAndToDoPage : Page
    {
        public PomodoroAndToDoPage()
        {
            InitializeComponent();
            InitializeTimer();
            Page.Background = PomodoroRedBrush;
            btnWork.Background = PomodoroDarkRedBrush;
            btnRest.Background = Brushes.Transparent;
            btnStartPause.Foreground = PomodoroRedBrush;
            tasks = new ObservableCollection<string>();
            taskListBox.ItemsSource = tasks;
        }
        private ObservableCollection<string> tasks;

        private DispatcherTimer timer;
        private const int workDurationDefault = 25 * 60; // Длительность работы в секундах
        private int workDuration = workDurationDefault;
        private const int restDurationDefault = 5 * 60; // Длительность отдыха в секундах
        private int restDuration = restDurationDefault;
        private bool isWorking = true; // Флаг для отслеживания текущего режима (работа/отдых)
        private bool isTimerRunning = false;
        private const string PomodoroRed = "#BA4949";
        private Brush PomodoroRedBrush = new SolidColorBrush((Color)ColorConverter.ConvertFromString(PomodoroRed));
        private const string PomodoroDarkRed = "#a03d3d";
        private Brush PomodoroDarkRedBrush = new SolidColorBrush((Color)ColorConverter.ConvertFromString(PomodoroDarkRed));
        private const string PomodoroBlue = "#38858A";
        private Brush PomodoroBlueBrush = new SolidColorBrush((Color)ColorConverter.ConvertFromString(PomodoroBlue));
        private const string PomodoroDarkBlue = "#307175";
        private Brush PomodoroDarkBlueBrush = new SolidColorBrush((Color)ColorConverter.ConvertFromString(PomodoroDarkBlue));

        public Brush currentColorTheme()
        {
            if (isWorking)
            {
                return PomodoroRedBrush;
            }
            else
            {
                return PomodoroBlueBrush;
            }
        }
        private void InitializeTimer()
        {
            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += Timer_Tick;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (isWorking)
            {
                workDuration--;
                timerDisplay.Text = FormatTime(workDuration);
                if (workDuration == 0)
                {
                    // Завершение периода работы, начало отдыха
                    isWorking = false;
                    workDuration = workDurationDefault; // Сброс длительности работы
                    timerDisplay.Text = FormatTime(restDuration);
                    Page.Background = currentColorTheme();
                    btnStartPause.Foreground = PomodoroBlueBrush;
                    btnRest.Background = PomodoroDarkBlueBrush;
                    btnWork.Background = Brushes.Transparent;
                }
            }
            else
            {
                restDuration--;
                timerDisplay.Text = FormatTime(restDuration);
                if (restDuration == 0)
                {
                    // Завершение периода отдыха, начало работы
                    isWorking = true;
                    restDuration = restDurationDefault; // Сброс длительности отдыха
                    timerDisplay.Text = FormatTime(workDuration);
                    Page.Background = PomodoroRedBrush;
                    btnStartPause.Foreground = PomodoroRedBrush;
                    btnWork.Background = PomodoroDarkRedBrush;
                    btnRest.Background = Brushes.Transparent;
                }
            }
        }

        private void BtnWork_Click(object sender, RoutedEventArgs e)
        {
            if (isTimerRunning)
            {
                if (isWorking)
                {
                    timer.Stop();
                    isTimerRunning = false;
                    btnStartPause.Content = "Старт";
                    workDuration = workDurationDefault;
                    timerDisplay.Text = FormatTime(workDuration);
                }
                else
                {
                    timer.Stop();
                    isWorking = true;
                    isTimerRunning = false;
                    btnStartPause.Content = "Старт";
                    timerDisplay.Text = FormatTime(workDuration);
                    Page.Background = PomodoroRedBrush;
                    btnStartPause.Foreground = PomodoroRedBrush;
                    btnWork.Background = PomodoroDarkRedBrush;
                    btnRest.Background = Brushes.Transparent;
                }
            }
            else
            {
                isWorking = true;
                workDuration = workDurationDefault;
                timerDisplay.Text = FormatTime(workDuration);
                Page.Background = PomodoroRedBrush;
                btnStartPause.Foreground = PomodoroRedBrush;
                btnWork.Background = PomodoroDarkRedBrush;
                btnRest.Background = Brushes.Transparent;
            }
        }

        private void BtnRest_Click(object sender, RoutedEventArgs e)
        {
            if (isTimerRunning)
            {
                if (isWorking)
                {
                    timer.Stop();
                    isWorking = false;
                    isTimerRunning = false;
                    btnStartPause.Content = "Старт";
                    timerDisplay.Text = FormatTime(restDuration);
                    Page.Background = currentColorTheme();
                    btnStartPause.Foreground = PomodoroBlueBrush;
                    btnWork.Background = Brushes.Transparent;
                    btnRest.Background = PomodoroDarkBlueBrush;
                }
                else
                {
                    timer.Stop();
                    isTimerRunning = false;
                    btnStartPause.Content = "Старт";
                    restDuration = restDurationDefault;
                    timerDisplay.Text = FormatTime(restDuration);
                }
            }
            else
            {
                isWorking = false;
                timerDisplay.Text = FormatTime(restDuration);
                Page.Background = currentColorTheme();
                btnStartPause.Foreground = PomodoroBlueBrush;
                btnRest.Background = PomodoroDarkBlueBrush;
                btnWork.Background = Brushes.Transparent;
            }
        }

        private void BtnStartPause_Click(object sender, RoutedEventArgs e)
        {
            if (isTimerRunning)
            {
                timer.Stop();
                btnStartPause.Content = "Старт";
            }
            else
            {
                timer.Start();
                btnStartPause.Content = "Пауза";
            }
            isTimerRunning = !isTimerRunning;
        }

        private string FormatTime(int seconds)
        {
            TimeSpan time = TimeSpan.FromSeconds(seconds);
            return string.Format("{0:D2}:{1:D2}", time.Minutes, time.Seconds);
        }
        private void AddTask_Click(object sender, RoutedEventArgs e)
        {
            string newTask = taskTextBox.Text.Trim();
            if (!string.IsNullOrEmpty(newTask))
            {
                tasks.Add(newTask);
                taskTextBox.Text = string.Empty;
            }
        }

        private void EditTask_Click(object sender, RoutedEventArgs e)
        {
            if (taskListBox.SelectedItem != null)
            {
                int selectedIndex = taskListBox.SelectedIndex;
                string editedTask = taskTextBox.Text.Trim();
                if (!string.IsNullOrEmpty(editedTask))
                {
                    tasks[selectedIndex] = editedTask;
                    taskTextBox.Text = string.Empty;
                }
            }
        }

        private void DeleteTask_Click(object sender, RoutedEventArgs e)
        {
            if (taskListBox.SelectedItem != null)
            {
                var selectedTasks = taskListBox.SelectedItems.Cast<string>().ToList();
                foreach (var task in selectedTasks)
                {
                    tasks.Remove(task);
                }
            }
        }

        private void TaskListBox_MouseDoubleClick(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (taskListBox.SelectedItem != null)
            {
                taskTextBox.Text = taskListBox.SelectedItem.ToString();
            }
        }

    } 
}
