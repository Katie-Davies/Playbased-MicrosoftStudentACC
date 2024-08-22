import { useQuery } from '@tanstack/react-query'
import { getAllFavourites } from '../apis/apiClient'

export function useGetFavourite(id: number) {
  return useQuery({
    queryKey: ['favourite'],
    queryFn: async () => await getAllFavourites(id),
  })
}
