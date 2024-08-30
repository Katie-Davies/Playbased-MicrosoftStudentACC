import Button from '../components/Button'
import SmallCard from '../components/smallCard'
import { useGetFavourite } from '../hooks/useGetFavourites'
import { useGetUserById } from '../hooks/useGetUserById'
import { Favourite } from '../models/models'

const data = {
  name: 'katie',
  email: 'millerjeor@me.com',
}

interface FavouritesProps {
  id: number
  title: string
  imgurl: string
}

function Favourites() {
  const { data: user, isLoading: userLoading } = useGetUserById(1)
  const { data: favourites, isLoading: favouritesLoading } = useGetFavourite(1)

  if (userLoading) {
    return <div>User is Loading...</div>
  }
  if (favouritesLoading) {
    return <div>Favourites are Loading...</div>
  }
  user && favourites
  console.log(
    favourites.map((favourite: Favourite) => {
      const activity = favourite.activity

      console.log(activity.activityName)
    })
  )
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
          <span className="font-extrabold text-xl">Name:</span> {user.name}
        </p>
        <p className="ml-5 mb-5">
          <span className="font-extrabold text-xl">Email:</span> {user.email}
        </p>
        <Button className="text-lg w-24 ml-24 mb-10">Edit</Button>
      </div>
      <div>
        <h1 className="font-sueEllen text-4xl text-customGreen mb-3 ml-5">
          Favourites
        </h1>
        {favourites.map(
          (favourite: FavouritesProps) => (
            console.log(favourite),
            (
              <SmallCard
                key={favourite.id}
                title={favourite.title}
                imgurl={favourite.imgurl}
                id={favourite.id}
              />
            )
          )
        )}
      </div>
    </>
  )
}

export default Favourites
