import SmallCard from '../components/smallCard'
import searchIcon from '../assets/icons8-search-50.png'
import Button from '../components/Button'

function Activities() {
  return (
    <div className="flex flex-col content-center flex-wrap items-center">
      <div className="flex justify-center">
        <h1 className="text-4xl md:text-6xl font-sueEllen text-customGreen">
          Activities
        </h1>
      </div>
      <div className="m-3 flex justify-between items-center w-9/12 md:w-1/2 bg-burntOrange  rounded-full p-2 relative">
        <input
          placeholder="Search"
          className="w-full bg-transparent pr-10 text-white font-montserrat text-2xl placeholder-white text-center rounded-full focus:outline-none p-2"
        />
        <img
          src={searchIcon}
          alt="search icon"
          className="w-6 h-6 absolute right-4 top-1/2 transform -translate-y-1/2"
        />
      </div>
      <div className="flex justify-center">
        <Button className="w-24 mx-4">0 - 2</Button>
        <Button className="w-24 mx-4">3 - 5</Button>

        <Button className="w-24 mx-4">6 - 8</Button>
        <Button className="w-24 mx-4">9-12</Button>
      </div>
      <div className="flex justify-around flex-wrap ">
        <SmallCard />
        <SmallCard />
        <SmallCard />
        <SmallCard />
      </div>
    </div>
  )
}

export default Activities
