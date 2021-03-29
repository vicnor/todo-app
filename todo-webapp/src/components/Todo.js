import React from 'react'
import { BiEditAlt } from 'react-icons/bi';

const Todo = ({todo, handleToggle}) => {

    const handleClick = (e) => {
        e.preventDefault()
        handleToggle(e.currentTarget.id)
    }

    return (
        <div id={todo.id} key={todo.id + todo.task} name="todo" value={todo.id} onClick={handleClick} className={todo.complete ? "todo strike" : "todo"}>
            {todo.title} <BiEditAlt />
        </div>
    )
}

export default Todo;
