import React from 'react';
import Todo from './Todo';
 
 
const ToDoList = ({todoList, handleToggle}) => {
   return (
       <div>
           {todoList.map(todo => {
               return (
                   <Todo key={todo.id} todo={todo} handleToggle={handleToggle} />
               )
           })}
       </div>
   );
};
 
export default ToDoList;