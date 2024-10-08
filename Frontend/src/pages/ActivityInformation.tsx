import { useParams } from 'react-router-dom'
import FavouriteButton from '../components/FavouriteButton'
import useGetActivityById from '../hooks/useGetActivityById'
import { Material } from '../models/models'

// const data = {
//   name: 'Chalk Painting',
//   image: GirlPaint,
//   Description:
//     'Mix water, cornFlower and food coloring to make chalk paint. Use paint brushes to paint the sidewalk.',
//   Materials: ['Water', 'CornFlower', 'Food Coloring', 'Paint Brushes'],
//   Duration: '30 minutes',
//   Age: ['0-1', '1-2', '2-3', '3-4', '4+'],
// }

function ActivityInformation() {
  const id = useParams<{ id: string }>().id

  const { data: activity, isLoading, isError } = useGetActivityById(Number(id))
  if (isLoading) {
    return <div>Loading...</div>
  }
  if (isError) {
    return <div>No Activity Found</div>
  }
  if (activity) {
    console.log(activity[0].activityMaterials)
  }

  return (
    <>
      <div className=" flex justify-center flex-wrap content-center  ">
        <div className="bg-customGreen rounded-2xl h-auto  max-h-md max-w-md w-64 md:w-1/3 flex justify-center mx-10 flex-col">
          <img
            src={activity[0].imageUrl}
            alt="girl Painting"
            className="m-5 rounded-2xl"
          />
        </div>
        <div className=" justify-center flex-col max-w-96 flex flex-wrap content-center text-center ">
          <div className="flex justify-center">
            <h1 className="text-6xl text-customGreen font-sueEllen m-3 pt-5 pb-5">
              {activity[0].activityName}
            </h1>
            <FavouriteButton activityId={activity[0].activityId} userId={1} />
          </div>
          <h1 className="font-bold text-xl">Materials:</h1>

          {activity[0].activityMaterials.map((material) => {
            return (
              <p key={material.material.materialID}>
                {material.material.materialName}
              </p>
            )
          })}

          {/* <p className="m-3"> {activity.join(', ')}</p> */}
          <h1 className="font-bold text-xl">Instructions:</h1>
          <p className="m-3"> {activity[0].description}</p>
          <h1 className="font-bold text-xl">Age:</h1>
          {/* <p className="m-3">{activity.Age.join(', ')}</p> */}
        </div>
      </div>
    </>
  )
}

export default ActivityInformation
