using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Threading;

namespace Pomodoro
{
    public delegate void WorkStatusHandler(bool isWorking);
    public partial class PomodoroAndToDoPage : Page
    {
        
        public PomodoroAndToDoPage()
        {
            InitializeComponent();
            InitializeTimer();
            Page.Background = pomodoroRedBrush;
            btnWork.Background = pomodoroDarkRedBrush;
            btnRest.Background = Brushes.Transparent;
            btnStartPause.Foreground = pomodoroRedBrush;
            tasks = new ObservableCollection<string>();
            taskListBox.ItemsSource = tasks;
        }
        private ObservableCollection<string> tasks;
        public event WorkStatusHandler StatusChanged;
        private DispatcherTimer timer;
        private const int workDurationDefault = 25 * 60; // Длительность работы в секундах
        private int workDuration = workDurationDefault;
        private const int restDurationDefault = 5 * 60; // Длительность отдыха в секундах
        private int restDuration = restDurationDefault;
        private bool isWorking = true; // Флаг для отслеживания текущего режима (работа/отдых)
        private bool isTimerRunning = false;
        private const string pomodoroRed = "#BA4949";
        private Brush pomodoroRedBrush = new SolidColorBrush((Color)ColorConverter.ConvertFromString(pomodoroRed));
        private const string pomodoroDarkRed = "#a03d3d";
        private Brush pomodoroDarkRedBrush = new SolidColorBrush((Color)ColorConverter.ConvertFromString(pomodoroDarkRed));
        private const string pomodoroBlue = "#38858A";
        private Brush pomodoroBlueBrush = new SolidColorBrush((Color)ColorConverter.ConvertFromString(pomodoroBlue));
        private const string pomodoroDarkBlue = "#307175";
        private Brush pomodoroDarkBlueBrush = new SolidColorBrush((Color)ColorConverter.ConvertFromString(pomodoroDarkBlue));

        public Brush currentColorTheme()
        {
            if (isWorking)
            {
                return pomodoroRedBrush;
            }
            else
            {
                return pomodoroBlueBrush;
            }
        }
        private void InitializeTimer()
        {
            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += timerTick;
        }
        private void setWork()
        {
            timer.Stop();
            isWorking = true;
            isTimerRunning = false;
            workDuration = workDurationDefault;
            timerDisplay.Text = formatTime(workDuration);
            btnStartPause.Foreground = pomodoroRedBrush;
            btnWork.Background = pomodoroDarkRedBrush;
            btnRest.Background = Brushes.Transparent;
            Page.Background = currentColorTheme();
            StatusChanged?.Invoke(isWorking);
        }
        private void setRest()
        {
            timer.Stop();
            isWorking = false;
            isTimerRunning = false;
            restDuration = restDurationDefault;
            timerDisplay.Text = formatTime(restDuration);
            btnStartPause.Foreground = pomodoroBlueBrush;
            btnRest.Background = pomodoroDarkBlueBrush;
            btnWork.Background = Brushes.Transparent;
            Page.Background = currentColorTheme();
            StatusChanged?.Invoke(isWorking);
        }
        private void timerTick(object sender, EventArgs e)
        {
            if (isWorking)
            {
                workDuration--; 
                timerDisplay.Text = formatTime(workDuration);
                if (workDuration == 0)
                {
                    // Завершение периода работы, начало отдыха
                    isWorking = false;
                    workDuration = workDurationDefault; // Сброс длительности работы
                    timerDisplay.Text = formatTime(restDuration);
                    setRest();
                }
            }
            else
            {
                restDuration--;
                timerDisplay.Text = formatTime(restDuration);
                if (restDuration == 0)
                {
                    // Завершение периода отдыха, начало работы
                    isWorking = true;
                    restDuration = restDurationDefault; // Сброс длительности отдыха
                    timerDisplay.Text = formatTime(workDuration);
                    setWork();
                }
            }
        }

        private void btnWorkClick(object sender, RoutedEventArgs e)
        {
            setWork();
            btnStartPause.Content = "Старт";
        }

        private void btnRestClick(object sender, RoutedEventArgs e)
        {
            setRest();
            btnStartPause.Content = "Старт";
        }

        private void btnStartPauseClick(object sender, RoutedEventArgs e)
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

        private string formatTime(int seconds)
        {
            TimeSpan time = TimeSpan.FromSeconds(seconds);
            return string.Format("{0:D2}:{1:D2}", time.Minutes, time.Seconds);
        }
        private void addTaskClick(object sender, RoutedEventArgs e)
        {
            string newTask = taskTextBox.Text.Trim();
            if (!string.IsNullOrEmpty(newTask))
            {
                tasks.Add(newTask);
                taskTextBox.Text = string.Empty;
            }
        }

        private void editTaskClick(object sender, RoutedEventArgs e)
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

        private void deleteTaskClick(object sender, RoutedEventArgs e)
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

        private void taskListBoxMouseDoubleClick(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (taskListBox.SelectedItem != null)
            {
                taskTextBox.Text = taskListBox.SelectedItem.ToString();
            }
        }

    } 
}
