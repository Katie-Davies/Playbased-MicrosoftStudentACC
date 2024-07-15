import SmallCard from '../components/smallCard'

function Activities() {
  return (
    <div className="flex flex-col content-center flex-wrap">
      <div className="flex justify-center">
        <h1 className="text-4xl md:text-6xl font-sueEllen text-customGreen">
          Activities
        </h1>
      </div>
      <div className="m-3 flex justify-center flex-wrap">
        <input
          placeholder="Search"
          className="w-1/3 bg-burntOrange text-white font-montserrat text-2xl rounded-full placeholder-white text-center focus:outline-none"
        ></input>
      </div>
      <div className="flex justify-around flex-wrap">
        <SmallCard />
        <SmallCard />
        <SmallCard />
        <SmallCard />
      </div>
    </div>
  )
}

export default Activities
