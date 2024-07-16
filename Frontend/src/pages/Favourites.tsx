import Button from '../components/Button'
import SmallCard from '../components/smallCard'

const data = {
  name: 'katie',
  email: 'millerjeor@me.com',
}

function Favourites() {
  return (
    <>
      <div className="flex flex-col">
        <h1 className="font-sueEllen text-4xl text-customGreen mb-10 text-center">
          My Favourites
        </h1>
        <h1 className="font-sueEllen text-4xl text-customGreen mb-3 ml-5">
          My details
        </h1>
        <p className="ml-5 mb-2">
          <span className="font-extrabold text-xl">Name:</span> {data.name}
        </p>
        <p className="ml-5 mb-5">
          <span className="font-extrabold text-xl">Email:</span> {data.email}
        </p>
        <Button className="text-lg w-24 ml-24 mb-10">Edit</Button>
      </div>
      <div>
        <h1 className="font-sueEllen text-4xl text-customGreen mb-3 ml-5">
          Favourites
        </h1>
        <SmallCard />
      </div>
    </>
  )
}

export default Favourites
