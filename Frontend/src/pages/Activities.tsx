import searchIcon from '../assets/icons8-search-50.png'
import Button from '../components/Button'
import { useState } from 'react'
import AllActivities from '../components/AllActivities'
import ActivitiesByAge from '../components/ActivitiesByAge'

import ActivitiesByMaterial from '../components/ActivitiesByMaterial'

function Activities() {
  const [selectedId, setSelectedId] = useState<number | null>(null)
  const [search, SetSearch] = useState<string>('')
  const [input, setInput] = useState<string>('')

  const handleButtonClick = (id: number) => {
    setSelectedId(id)
  }

  function handleChange(e: React.ChangeEvent<HTMLInputElement>) {
    console.log(e.target.value)
    SetSearch(e.target.value)
    setInput(e.target.value)
    setSelectedId(null)
  }
  function handleSubmit(e: React.FormEvent<HTMLFormElement>) {
    e.preventDefault()
    setInput('')
    // SetSearch('')
  }
  return (
    <div className="flex flex-col content-center flex-wrap items-center">
      <div className="flex justify-center">
        <h1 className="text-4xl md:text-6xl font-sueEllen text-customGreen">
          Activities
        </h1>
      </div>
      <div className="m-3 flex justify-between items-center w-9/12 md:w-1/2 bg-burntOrange rounded-full p-2 relative">
        <form onSubmit={handleSubmit}>
          <input
            placeholder="Search"
            className="w-full bg-transparent pr-10 text-white font-montserrat text-2xl placeholder-white text-center rounded-full focus:outline-none p-2"
            onChange={handleChange}
            value={input}
          />
        </form>
        <img
          src={searchIcon}
          alt="search icon"
          className="w-6 h-6 absolute right-4 top-1/2 transform -translate-y-1/2"
        />
      </div>
      <div className="flex justify-center">
        <Button className="w-24 mx-4" onClick={() => handleButtonClick(1)}>
          0 - 2
        </Button>
        <Button className="w-24 mx-4" onClick={() => handleButtonClick(2)}>
          3 - 5
        </Button>
        <Button className="w-24 mx-4" onClick={() => handleButtonClick(3)}>
          6 - 8
        </Button>
        <Button className="w-24 mx-4" onClick={() => handleButtonClick(4)}>
          9-12
        </Button>
      </div>
      {selectedId !== null ? (
        <ActivitiesByAge selectedId={selectedId} />
      ) : search !== '' ? (
        <ActivitiesByMaterial search={search} />
      ) : (
        <AllActivities />
      )}
    </div>
  )
}

export default Activities
