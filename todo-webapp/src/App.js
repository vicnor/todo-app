import React, { useState } from 'react';
import './App.css';
import Header from './components/Header';
import data from './data.json';
import TodoList from './components/TodoList';

function App() {

  const [ todoList, setTodoList ] = useState(data);

  const handleToggle = (id) => {
    let mapped = todoList.map(task => {
      return task.id == id ? { ...task, complete: !task.complete } : { ...task };
    });
    setTodoList(mapped);
  }

  return (
    <div className="todo-app">
      <Header />
      <TodoList handleToggle={handleToggle} todoList={todoList}/>
    </div>
  );
}

export default App;
