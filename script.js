let taskArray = [];
let completedTasksArray = [];

let addTaskButton = document.querySelector("#addTaskBtn");
let taskInput = document.querySelector("#taskInput");

addTaskButton.addEventListener('click', () => {
  let taskText = taskInput.value.trim();

  if (taskText === "") {
    alert("You should add the task");
    return;
  }

  if (taskArray.includes(taskText)) {
    alert("This task already exists");
  } else {
    taskArray.push(taskText);
    displayTasks();
  }

  taskInput.value = "";
});

function displayTasks() {
  let taskList = document.querySelector("#taskList");
  taskList.innerHTML = "";

  taskArray.forEach((task, index) => {
    let li = document.createElement("li");
    li.className = "list-group-item d-flex justify-content-between align-items-center";

    let taskSpan = document.createElement("span");
    taskSpan.innerText = task;

    let buttonGroup = document.createElement("div");

    let completeButton = document.createElement("button");
    completeButton.innerText = "Complete";
    completeButton.className = "btn btn-success btn-sm me-2";
    completeButton.addEventListener("click", function () {
      completeTask(index);
    });

    let deleteButton = document.createElement("button");
    deleteButton.innerText = "Delete";
    deleteButton.className = "btn btn-danger btn-sm";
    deleteButton.addEventListener("click", function () {
      deleteTask(index);
    });

    buttonGroup.appendChild(completeButton);
    buttonGroup.appendChild(deleteButton);

    li.appendChild(taskSpan);
    li.appendChild(buttonGroup);
    taskList.appendChild(li);
  });
}

function displayCompletedTasks() {
  let completedList = document.querySelector("#completedList");
  completedList.innerHTML = "";

  completedTasksArray.forEach((task, index) => {
    let li = document.createElement("li");
    li.className = "list-group-item d-flex justify-content-between align-items-center";

    let taskSpan = document.createElement("span");
    taskSpan.innerText = task;

    let deleteButton = document.createElement("button");
    deleteButton.innerText = "Delete";
    deleteButton.className = "btn btn-danger btn-sm";
    deleteButton.addEventListener("click", function () {
      deleteCompletedTask(index);
    });

    li.appendChild(taskSpan);
    li.appendChild(deleteButton);
    completedList.appendChild(li);
  });
}

function completeTask(index) {
  completedTasksArray.push(taskArray[index]);
  taskArray.splice(index, 1);
  displayTasks();
  displayCompletedTasks();
}

function deleteTask(index) {
  taskArray.splice(index, 1);
  displayTasks();
}

function deleteCompletedTask(index) {
  completedTasksArray.splice(index, 1);
  displayCompletedTasks();
}
