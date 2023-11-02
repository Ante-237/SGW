# SGW
Virtual and Augmented Reality Specialization Group work. 


## STOP WATCH MECHANISM

----
### TASKS/FUNCTIONALITIES

1. The time format should be 00:00:00 for (hours:mins:secs)
2. The start button should start the watch from the secs and adds up to minutes and hours
3. The pause button should pause the stopwatch and prints its current value to the console or display the current value
4. The resume button should continue the stopwatch from when it was paused
5. The reset button should set the watch back to 00:00:00
6. The stop button should stop the watch and display the last read value

### DOCUMENTATION
1. the stop watch uses TKinter library to create simple grphical interface for thr stopwatch
2. The 'start' method starts the stopwatch timer. it records thre current time when the user clicks "start" and update the elasped time continuously
3. The 'stop' methid stops the stopwatch timer
4. The 'reset' method resets the stop watch timer to zero
3. The 'update' method updates the displayed time by calculating the elapsed time and scheduling itself to run again after 1 second if the stopwatch is running.
4. The update_time method formats and updates the time displayed on the GUI
5. The if __name__ == "__main__": block initializes the GUI and starts the stopwatch application.
---


### UNIT TEST
---
