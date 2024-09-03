import Button from '../components/Button'
import SmallCard from '../components/smallCard'
import { useGetFavourite } from '../hooks/useGetFavourites'
import { useGetUserById } from '../hooks/useGetUserById'
import { Favourite } from '../models/models'

interface FavouritesProps {
  id: number
  title: string
  imgurl: string
}

function Favourites() {
  const { data: user, isLoading: userLoading } = useGetUserById(3)
  const { data: favourites, isLoading: favouritesLoading } = useGetFavourite(3)

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

      console.log('activity name', activity.activityName)
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
        <div className="flex flex-wrap">
          {favourites.map((favourite: FavouritesProps) => (
            <SmallCard
              key={favourite.activity.activityId}
              title={favourite.activity.activityName}
              imgurl={favourite.activity.imageUrl}
              id={favourite.activity.activityId}
            />
          ))}
        </div>
      </div>
    </>
  )
}

export default Favourites
