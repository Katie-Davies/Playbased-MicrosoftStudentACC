import SmallCard from '../components/smallCard'
import { Activity } from '../models/models'
import { useGetActivityByMaterial } from '../hooks/useGetActivityByMaterial'

function ActivitiesByMaterial({ search }: { search: string }) {
  const { data: activitiesByMaterial, isLoading: activitiesByAgeLoading } =
    useGetActivityByMaterial(search)

  if (activitiesByAgeLoading) {
    return <div>Loading...</div>
  }
  if (activitiesByMaterial) {
    console.log(activitiesByMaterial)
  }

  return (
    <div className="flex justify-around flex-wrap">
      {activitiesByMaterial?.map((activity: Activity) => (
        <SmallCard
          key={activity.activityId}
          title={activity.activityName}
          description={activity.description}
          ageGroupID={activity.ageGroupID}
          categoryID={activity.categoryID}
          materials={activity.materials}
          imgurl={activity.imageUrl}
          id={activity.activityId}
        />
      ))}
    </div>
  )
}

export default ActivitiesByMaterial
